

namespace OBS.Model
{
    /// <summary>
    /// ɾ���������Ӧ�����
    /// </summary>
    public class DeleteObjectResponse : ObsWebServiceResponse
    {

        /// <summary>
        ///��ʶɾ���Ķ����Ƿ���ɾ����ǡ�
        /// </summary>
        public bool DeleteMarker
        {
            get;
            internal set;
        }

        /// <summary>
        /// ��ɾ������İ汾�š�
        /// </summary>
        public string VersionId
        {
            get;
            internal set;
        }

    }
}
    
