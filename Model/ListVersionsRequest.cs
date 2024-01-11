

namespace OBS.Model
{
    /// <summary>
    /// �о�Ͱ�ڶ�汾��������������
    /// </summary>
    public class ListVersionsRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "ListVersions";
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
        /// �оٶ�汾�������ʼλ�ã������������򣩡�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// ���صĶ����б��Ƕ����������ֵ��������ò����Ժ�����ж���
        /// </para>
        /// </remarks>
        public string KeyMarker
        {
            get;
            set;
        }



        /// <summary>
        /// �оٶ�汾����������Ŀ����
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// ȡֵ��ΧΪ1~1000����������Χʱ������Ĭ�ϵ�1000���д���
        /// </para>
        /// </remarks>
        public int? MaxKeys
        {
            get;
            set;
        }


        /// <summary>
        /// �оٶ�汾����ʱ�Ķ�����ǰ׺��
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



        /// <summary>
        /// �оٶ�汾�������ʼλ�ã�������汾�����򣩡�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// ��KeyMarker���ʹ�ã����صĶ����б��Ƕ������Ͱ汾�Ű����ֵ��������ò����Ժ�����ж���
        /// ���VersionIdMarker����KeyMarker��һ���汾�ţ���ò�����Ч��
        /// </para>
        /// </remarks>
        public string VersionIdMarker
        {
            get;
            set;
        }

    }
}

