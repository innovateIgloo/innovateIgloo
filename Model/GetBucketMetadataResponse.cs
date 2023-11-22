
using System.Collections.Generic;

namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰԪ���ݵ���Ӧ�����
    /// </summary>
    public class GetBucketMetadataResponse : ObsWebServiceResponse
    {
        /// <summary>
        /// Ͱ�Ĵ洢���͡�
        /// </summary>
        public StorageClassEnum? StorageClass
        {
            get;
            internal set;
        }

        /// <summary>
        /// Ͱ������λ�á�
        /// </summary>
        public string Location
        {
            get;
            internal set;
        }

        /// <summary>
        /// OBS����İ汾��
        /// </summary>
        public string ObsVersion
        {
            get;
            internal set;
        }

        /// <summary>
        /// Ͱ�ļ�Ⱥ���͡�
        /// </summary>
        public AvailableZoneEnum AvailableZone
        {
            get;
            internal set;
        }

    }
}
    
