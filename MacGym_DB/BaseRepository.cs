using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MacGym_DB
{
    public class DebugTextWriter : System.IO.TextWriter
    {
        public static DebugTextWriter Out
        {
            get
            {
                return new DebugTextWriter();
            }
        }

        public override void Write(char[] buffer, int index, int count)
        {
            System.Diagnostics.Debug.Write(new String(buffer, index, count));
        }

        public override void Write(string value)
        {
            System.Diagnostics.Debug.Write(value);
        }

        public override Encoding Encoding
        {
            get { return System.Text.Encoding.Default; }
        }
    }

    public abstract class BaseRepository
    {
        private MacGymDataContext _db = null;
        protected MacGymDataContext DB
        {
            get
            {
                if (_db == null)
                {
                    _db = new MacGymDataContext();
#if DEBUG
                    _db.Log = DebugTextWriter.Out;
#endif
                }

                return _db;
            }
        }

        public byte[] ComputeHash(string textToHash)
        {
            //Some random string
            string salt = "%s5&%s#1!_@a";
            byte[] saltBytes = ASCIIEncoding.UTF8.GetBytes(salt);
            byte[] textBytes = ASCIIEncoding.UTF8.GetBytes(textToHash);

            var md5 = new HMACMD5(saltBytes);
            return md5.ComputeHash(textBytes);
        }

        protected bool SubmitChanges()
        {
            bool successed = true;

            try
            {
                DB.SubmitChanges();
            }
            catch (Exception ex)
            {
                successed = false;
#if DEBUG
                throw ex;
#else
                Log(ex);
#endif
            }

            return successed;
        }

        protected void Log(Exception ex)
        {
            //TODO
        }

        public bool Update()
        {
            return SubmitChanges();
        }
    }
}
