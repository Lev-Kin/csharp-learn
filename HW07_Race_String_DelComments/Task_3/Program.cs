string pattern = @"(?x)
( ""
  (?> (?<=@.) (?>[^""]+|"""")*  
    | (?> [^""\\]+ | \\. )* 
  ) 
  ""
| ' (?> [^'\\]+ | \\. )* '
)
| // .* 
| /\* (?s) .*? \*/ ";
 
str = Regex.Replace(str, pattern, "$1");

//==========================================================

using System;
using System.IO;
using System.Text;
 
namespace CommentParser
{
 
    public class CommentParser : IDisposable
    {
        private TextReader _reader;
        private int _pos = -1;
        private bool _eof = false;
        private char[] _buffer;
        private int _buffSize = 4096;
        private bool _leaveOpen = false;
        private int _charsRead = 0;
        private bool _disposed;
        private int state = 0;
 
        public CommentParser(TextReader reader, bool leaveOpen = false)
        {
            _reader = reader;
            _leaveOpen = leaveOpen;
        }
 
        /* Состояния state:
            0 - считан обычный символ
            1 - считан слэш /, подозрение на открытие коммента
            2 - считан астериск * после слэша - открытый коммент
            3 - считан астериск *, подозрение на закрытие коммента
        */
        public string GetString()
        {
            var sb = new StringBuilder();
            var sym = GetSym();
            while (sym != 0)
            {
                switch (state)
                {
                    case 0:
                        switch (sym)
                        {
                            case '\0':
                                return sb.ToString();
                            case '*':
                                sb.Append(sym);
                                sym = GetSym();
                                break;
                            case '/':
                                state = 1;
                                sym = GetSym();
                                if (sym == 0) sb.Append("/");
                                break;
                            default:
                                sb.Append(sym);
                                sym = GetSym();
                                break;
                        }
                        break;
                    case 1:
                        switch (sym)
                        {
 
                            case '\0':
                                return sb.ToString();
 
                            case '*':
                                sym = GetSym();
                                state = 2; //Комментерий открыт
                                return sb.ToString();
 
                            case '/':
                                sb.Append("/");
                                sym = GetSym();
                                if (sym == 0) sb.Append("/");
                                break;
                            default:
                                sb.Append("/" + sym);
                                sym = GetSym();
                                state = 0;
                                break;
                        }
                        break;
                    case 2:
                        switch (sym)
                        {
 
                            case '\0':
                                return sb.ToString();
                            case '*':
                                state = 3; //подозрение закрытого комментария
                                break;
                            case '/':
                                sym = GetSym();
                                break;
                            default:
                                sym = GetSym();
                                break;
                        }
 
                        break;
                    case 3:
                        switch (sym)
                        {
 
                            case '\0':
                                return sb.ToString();
                            case '*':
                                sym = GetSym();
                                break;
                            case '/':
                                sym = GetSym();
                                state = 0; //состояние закрытого комментария
 
                                break;
                            default:
                                sym = GetSym();
                                state = 2;
                                break;
                        }
                        break;
 
                }
            }
            return sb.ToString();
        }
 
        private char GetSym()
        {
 
            _pos++;
            if (_buffer == null || _pos == _buffer.Length)
            {
                _charsRead = ReadToBuffer();
                _pos = 0;
            }
 
            if (_pos == _charsRead)
            {
                _eof = true;
                return '\0';
            }
            return _buffer[_pos];
        }
    
 
        public bool EOF
        {
            get 
            { 
                return _eof;  
            }
        }
 
        private int ReadToBuffer()
        {
            if (_buffer == null)
            {
                _buffer = new char[_buffSize];
            }
            else
            {
                Array.Clear(_buffer, 0, _buffer.Length);
            }
            return _reader.Read(_buffer, 0, _buffer.Length);
        }
 
        public virtual void Close()
        {
            Dispose(true);
        }
 
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
 
        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (!this._disposed)
                {
                    this.CloseReader();
                }
                this._disposed = true;
            }
        }
 
 
        private void CloseReader()
        {
            FinishReading();
            if (_reader != null)
            {
                if (!_leaveOpen)
                {
                    this._reader.Close();
                }
                _reader = null;
            }
        }
 
        private void FinishReading()
        {
         
            _eof = true;
            _buffer = null;
        }
    }
}

