
using System.Collections.Generic;

namespace OBS.Model
{   
    /// <summary>
    /// ��֪ͨ��������.
    /// </summary>
    public class TopicConfiguration
    {
        List<EventTypeEnum> _events;
        List<FilterRule> _filterRules;

        /// <summary>
        /// ��֪ͨ��������ID.
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
                return this._filterRules ?? (this._filterRules = new List<FilterRule>());
            }
            set { this._filterRules = value; }
        }
    }
}
