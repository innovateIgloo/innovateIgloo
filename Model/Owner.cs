

using System;

namespace OBS.Model
{
    /// <summary>
    /// Ͱ��������������Ϣ��
    /// </summary>
    public class Owner
    {
        /// <summary>
        /// �����ߵ����ơ�
        /// </summary>
        [Obsolete]
        public string DisplayName { set; get; }

        /// <summary>
        /// �����ߵ�DomainId��
        /// </summary>
        public string Id { get; set; }
    }
}
