
using System;

namespace OBS.Model
{
    /// <summary>
    /// �ֶ��ϴ�����Ĵ����ߡ�
    /// </summary>
    public class Initiator
    {


        /// <summary>
        /// �û�����
        /// </summary>
        [Obsolete]
        public string DisplayName
        {
            get;
            set;
        }

        /// <summary>
        /// �û���DomainId��
        /// </summary>
        public string Id
        {
            get;
            set;
        }

    }
}
