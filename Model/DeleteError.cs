
namespace OBS.Model
{
    /// <summary>
    /// ����ɾ��ʧ�ܵĽ����
    /// </summary>
    public class DeleteError
    {
        

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

        /// <summary>
        /// ɾ��ʧ�ܵĴ����롣
        /// </summary>
        public string Code
        {
            get;
            internal set;
        }

        /// <summary>
        ///  ɾ��ʧ�ܵĴ�����Ϣ��
        /// </summary>
        public string Message
        {
            get;
            internal set;
        }
    }
}
