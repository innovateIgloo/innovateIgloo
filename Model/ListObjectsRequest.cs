


using System.Collections.Generic;

namespace OBS.Model
{
    /// <summary>
    /// �о�Ͱ�ڶ�������������
    /// </summary>
    public class ListObjectsRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "ListObjectsRequest";
        }


        /// <summary>
        /// ���������з�����ַ���
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// ���ڶ������а���Delimiter�Ķ���������������������ָ����Prefix����˴��Ķ�������Ҫȥ��Prefix��
        /// �д����ַ�����һ��Delimiter֮����ַ�������Ϊһ�����鲢��ΪCommonPrefix���ء�
        /// </para>
        /// </remarks>
        public string Delimiter
        {
            get;
            set;
        }



        /// <summary>
        /// �оٶ���ʱ����ʼλ�á�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// �оٶ������ʼλ�ã����صĶ����б��Ƕ����������ֵ��������ò����Ժ�����ж���
        /// </para>
        /// </remarks>
        public string Marker
        {
            get;
            set;
        }


        /// <summary>
        /// �оٶ���������Ŀ����
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��Ĭ���о����1000������
        /// </para>
        /// </remarks>
        public int? MaxKeys
        {
            get;
            set;
        }



        /// <summary>
        /// �оٶ���ʱ�Ķ�����ǰ׺��
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string Prefix
        {
            get;
            set;
        }

    }
}
    
