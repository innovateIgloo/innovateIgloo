
using System.Collections.Generic;

namespace OBS.Model
{
    /// <summary>
    /// Ͱ�Ŀ�����Դ�������á�
    /// </summary>
    public class CorsConfiguration
    {

        private IList<CorsRule> rules;

        /// <summary>
        /// Ͱ�Ŀ�����Դ��������б�.
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public IList<CorsRule> Rules
        {
            get {
                
                return this.rules ?? (this.rules = new List<CorsRule>()); }
            set { this.rules = value; }
        }

    }
}
