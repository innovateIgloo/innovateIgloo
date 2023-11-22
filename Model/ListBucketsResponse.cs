
using System.Collections.Generic;

namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰ�б����Ӧ�����
    /// </summary>
    public class ListBucketsResponse : ObsWebServiceResponse
    {
        private IList<ObsBucket> buckets;

        /// <summary>
        /// Ͱ�б�
        /// </summary>
        public IList<ObsBucket> Buckets
        {
            get {
                
                return this.buckets ?? (this.buckets = new List<ObsBucket>()); }
            internal set { this.buckets = value; }
        }

        /// <summary>
        /// Ͱ�������ߡ�
        /// </summary>
        public Owner Owner
        {
            get;
            internal set;
        }

    }
}
    
