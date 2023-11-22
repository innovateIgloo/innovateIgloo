
using System.Collections.Generic;

namespace OBS.Model
{   
    /// <summary>
    /// �¼�֪ͨ����.
    /// </summary>
    public class TopicConfiguration
    {
        List<EventTypeEnum> _events;

        /// <summary>
        /// �¼�֪ͨ����ID.
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string Id { get; set; }


        /// <summary>
        /// �¼�֪ͨ�����URN����OBS��⵽Ͱ�з����ض����¼��󣬽��ᷢ��֪ͨ��Ϣ�������⡣
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string Topic { get; set; }

       
        /// <summary>
        /// ��Ҫ����֪ͨ��Ϣ���¼������б�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public List<EventTypeEnum> Events
        { 
            get
            {
                return this._events ?? (this._events = new List<EventTypeEnum>());
            }
            set { this._events = value; } 
        }
        
        public List<FilterRule> filterRules;
        /// <summary>
        /// �¼�֪ͨ���õĹ��˹����б�.
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public List<FilterRule> FilterRules
        {
            get
            {
                return this.filterRules ?? (this.filterRules = new List<FilterRule>());
            }
            set { this.filterRules = value; }
        }
    }
}
