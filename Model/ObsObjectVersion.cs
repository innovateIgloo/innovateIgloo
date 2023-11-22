
namespace OBS.Model
{
    /// <summary>
    /// ��汾������Ϣ��
    /// </summary>
    public class ObsObjectVersion : ObsObject
    {

        /// <summary>
        /// �Ƿ������°汾��
        /// </summary>
        public bool IsLatest
        {
            get;
            internal set;
        }

        /// <summary>
        /// �汾�š�
        /// </summary>
        public string VersionId
        {
            get;
            internal set;
        }

        /// <summary>
        /// �Ƿ����ö���ɾ����ǡ�
        /// </summary>
        public bool IsDeleteMarker
        {
            get;
            internal set;
        }
    }
}
