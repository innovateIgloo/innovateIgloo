
using System.Collections.Generic;

namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰԪ������Ϣ�����������
    /// </summary>
    public class GetBucketMetadataRequest : ObsBucketWebServiceRequest
    {
        private IList<string> accessControlRequestHeaders;


        /// <summary>
        /// Ԥ����ָ���Ŀ�������Origin��ͨ��Ϊ��������
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string Origin
        {
            get;
            set;
        }


        /// <summary>
        ///  �����������ʹ�õ�HTTPͷ��
        ///  </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public IList<string> AccessControlRequestHeaders
        {
            get { return this.accessControlRequestHeaders ?? (this.accessControlRequestHeaders = new List<string>()); }
            set { this.accessControlRequestHeaders = value; }
        }

        internal override string GetAction()
        {
            return "GetBucketMetadata";
        }

    }
}
    
