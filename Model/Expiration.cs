
using System;

namespace OBS.Model
{
    /// <summary>
    /// �������ʱ�����á�
    /// </summary>
    public class Expiration
    {
        
        /// <summary>
        /// ����������ڣ� ��ʾ������ڵľ������ڡ� 
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���û������Days���ѡ��
        /// </para>
        /// </remarks>
        public DateTime? Date
        {
            get;
            set;
        }

        /// <summary>
        /// �������ʱ�䣬��ʾ�ڶ��󴴽�ʱ���ڼ���ʱ���ڡ�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���û������Date���ѡ��
        /// </para>
        /// </remarks>
        public int? Days
        {
            get;
            set;
        }
    }
}
