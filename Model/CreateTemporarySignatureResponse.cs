
using System;
using System.Collections.Generic;

namespace OBS.Model
{
    /// <summary>
    /// ��ʱ��Ȩ��Ӧ�����
    /// </summary>
    public class CreateTemporarySignatureResponse
    {
        private IDictionary<string, string> actualSignedRequestHeaders;
            
        /// <summary>
        /// ��ʱ��ȨURL
        /// </summary>
        public string SignUrl
        {
            get;
            internal set;
        }

        /// <summary>
        /// ʵ�����ڼ�Ȩ��ͷ��
        /// </summary>
        public IDictionary<String,String> ActualSignedRequestHeaders
        {
            get {
                
                return this.actualSignedRequestHeaders ?? (this.actualSignedRequestHeaders = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)); }
            internal set { this.actualSignedRequestHeaders = value; }
        }

    }
}
    
