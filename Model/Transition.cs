
using System;

namespace OBS.Model
{
    /// <summary>
    /// ����ת�����ԡ�
    /// </summary>
    public class Transition
    {
        

        /// <summary>
        /// ����ת�����ڣ� ��ʾ����ת���ľ������ڡ�
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
        /// ����ת��ʱ�䣬��ʾ�ڶ��󴴽�ʱ���ڼ���ʱ�Զ�ת���� 
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


        /// <summary>
        /// ����ת����Ĵ洢���
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public StorageClassEnum? StorageClass
        {
            get;
            set;
        }
    }
}
