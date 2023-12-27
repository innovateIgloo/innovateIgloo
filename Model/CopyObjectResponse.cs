
using System;

namespace OBS.Model
{
    /// <summary>
    /// ���ƶ������Ӧ�����
    /// </summary>
    public class CopyObjectResponse : ObsWebServiceResponse
    {

        /// <summary>
        /// Ŀ������etagֵ��
        /// </summary>
        public string ETag
        {
            get;
            internal set;
        }

        /// <summary>
        /// Ŀ����������޸�ʱ�䡣
        /// </summary>
        public DateTime? LastModified
        {
            get;
            internal set;
        }

        /// <summary>
        /// Ŀ�����Ĵ洢���͡�
        /// </summary>
        public StorageClassEnum? StorageClass
        {
            get;
            internal set;
        }

        /// <summary>
        /// Դ����İ汾�š�
        /// </summary>
        public string SourceVersionId
        {
            get;
            internal set;
        }

        /// <summary>
        /// Ŀ�����İ汾�š�
        /// </summary>
        public string VersionId
        {
            get;
            internal set;
        }

    }
}
    
