
using System.Collections.Generic;

namespace OBS.Model
{
    /// <summary>
    /// Ͱ�������������á�
    /// </summary>
    public class LifecycleConfiguration
    {

        private IList<LifecycleRule> rules;

        /// <summary>
        /// Ͱ���������ڹ����б�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public IList<LifecycleRule> Rules
        {
            get {
               
                return this.rules ?? (this.rules = new List<LifecycleRule>()); }
            set { this.rules = value; }
        }

    }
}
