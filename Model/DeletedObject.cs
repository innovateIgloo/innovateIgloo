
namespace OBS.Model
{
    /// <summary>
    /// ����ɾ���ɹ��Ķ���
    /// </summary>
    public class DeletedObject
    {
        

        /// <summary>
        /// ��ʶ�����Ƿ���ɾ����
        /// </summary>
        public bool DeleteMarker
        {
            get;
            internal set;
        }

        /// <summary>
        /// ɾ����ǵİ汾�š�
        /// </summary>
        public string DeleteMarkerVersionId
        {
            get;
            internal set;
        }

        /// <summary>
        /// ��������
        /// </summary>
        public string ObjectKey
        {
            get;
            internal set;
        }

        /// <summary>
        /// ����汾�š�
        /// </summary>
        public string VersionId
        {
            get;
            internal set;
        }

    }
}
