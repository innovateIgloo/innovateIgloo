
using System;

namespace OBS.Model
{
    /// <summary>
    /// ����Ȩ�û���Ϣ��
    /// </summary>
    public class CanonicalGrantee : Grantee
    {
        
        public CanonicalGrantee()
        {

        }

        /// <summary>
        /// ���캯����
        /// </summary>
        /// <param name="id">����Ȩ�û���DomainId��</param>
        public CanonicalGrantee(string id)
        {
            this.Id = id;
        }

        /// <summary>
        /// ����Ȩ�û����û�����
        /// </summary>
        [Obsolete]       
        public string DisplayName
        {
            get;
            set;
        }


        /// <summary>
        /// ����Ȩ�û���DomainId��
        /// </summary>
        public string Id
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

            if(this.GetType() != obj.GetType())
            {
                return false;
            }

            CanonicalGrantee _obj = obj as CanonicalGrantee;
            if (string.IsNullOrEmpty(this.Id))
            {
                if (string.IsNullOrEmpty(_obj.Id))
                {
                    return true;
                }
                return false;
            }
            return this.Id.Equals(_obj.Id);        
        }

        public override int GetHashCode()
        {
            return string.IsNullOrEmpty(this.Id) ? 0 : this.Id.GetHashCode();
        }
    }
}
