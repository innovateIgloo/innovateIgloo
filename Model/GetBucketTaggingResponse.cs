
using System.Collections.Generic;


namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰ��ǩ����Ӧ�����
    /// </summary>
    public class GetBucketTaggingResponse : ObsWebServiceResponse
    {

        private IList<Tag> tags;
        /// <summary>
        /// Ͱ��ǩ�б�
        /// </summary>
        public IList<Tag> Tags
        {
            get {
                
                return this.tags ?? (this.tags = new List<Tag>()); }
            internal set { this.tags = value; }
        }

    }
}
    
