

namespace OBS.Model
{
    /// <summary>
    /// ����Ȩ���û�/�û��鼰���Ӧ��Ȩ����Ϣ��
    /// </summary>
    public class Grant
    {
        

        /// <summary>
        /// ����Ȩ���û�/�û��顣
        /// </summary>
        public Grantee Grantee
        {
            get;
            set;
        }

        /// <summary>
        /// Ȩ����Ϣ��
        /// </summary>
        public PermissionEnum? Permission
        {
            get;
            set;
        }

        /// <summary>
        /// Ͱ�ķ���Ȩ�޴��ݱ�ʶ��ֻ��ͰȨ����Ч��
        /// </summary>
        public bool Delivered
        {
            set;
            get;
        }

    }
}
