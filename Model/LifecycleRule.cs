
using System.Collections.Generic;
namespace OBS.Model
{
    /// <summary>
    /// �������ڹ���
    /// </summary>
    public class LifecycleRule
    {
        
        private IList<Transition> transitions;
        private IList<NoncurrentVersionTransition> noncurrentVersionTransitions;

        /// <summary>
        /// �������ʱ�����á�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public Expiration Expiration
        {
            get;
            set;
        }

        /// <summary>
        ///  ����ID���ɲ�����255���ַ����ַ�����ɡ�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string Id
        {
            get;
            set;
        }


        /// <summary>
        /// ������ƥ��Ķ�����ǰ׺��  
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ�����Ա�ʶ��Щ�������ƥ�䵽��ǰ�������򡣿�Ϊ���ַ���������ƥ��Ͱ�����ж���
        /// </para>
        /// </remarks>
        public string Prefix
        {
            get;
            set;
        }


        /// <summary>
        /// ����״̬��
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public RuleStatusEnum Status
        {
            get;
            set;
        }

        /// <summary>
        /// ����ת�����ԡ�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public IList<Transition> Transitions
        {
            get {
                return this.transitions ?? (this.transitions = new List<Transition>()); }
            set { this.transitions = value; }
        }

        /// <summary>
        /// ��ʷ�汾�������ʱ�����á�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public NoncurrentVersionExpiration NoncurrentVersionExpiration
        {
            get;
            set;
        }

        /// <summary>
        /// ��ʷ�汾����ת�����ԡ�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public IList<NoncurrentVersionTransition> NoncurrentVersionTransitions
        {
            get {
                return this.noncurrentVersionTransitions ?? (this.noncurrentVersionTransitions = new List<NoncurrentVersionTransition>()); }
            set { this.noncurrentVersionTransitions = value; }
        }

    }
}
