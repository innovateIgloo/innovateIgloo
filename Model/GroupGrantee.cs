
namespace OBS.Model
{
    /// <summary>
    /// ����Ȩ���û�����Ϣ��
    /// </summary>
    public class GroupGrantee : Grantee
    {

        public GroupGrantee()
        {

        }

        /// <summary>
        /// ���캯����
        /// </summary>
        /// <param name="groupGranteeType">����Ȩ�û������͡�</param>
        public GroupGrantee(GroupGranteeEnum groupGranteeType)
        {
            this.GroupGranteeType = groupGranteeType;
        }

        /// <summary>
        /// ����Ȩ�û������͡�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public GroupGranteeEnum? GroupGranteeType
        {
            get;
            set;
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }

            if(obj.GetType() != this.GetType())
            {
                return false;
            }

            GroupGrantee _obj = obj as GroupGrantee;
            return this.GroupGranteeType == _obj.GroupGranteeType;
        }

        public override int GetHashCode()
        {
            return this.GroupGranteeType.GetHashCode();
        }

    }
}
