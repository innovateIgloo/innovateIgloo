
using System.Collections.Generic;

namespace OBS.Model
{
    /// <summary>
    /// ����Ͱ��ǩ�����������
    /// </summary>
    public class SetBucketTaggingRequest : ObsBucketWebServiceRequest
    {
        private IList<Tag> tags;

        internal override string GetAction()
        {
            return "SetBucketTagging";
        }

        /// <summary>
        /// Ͱ��ǩ�б�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// ÿ��Ͱ֧�����10��Tag��
        /// </para>
        /// </remarks>
        public IList<Tag> Tags
        {
            get {
                
                return this.tags ?? (this.tags = new List<Tag>());
            }
            set { this.tags = value; }
        }

    }
}
    
