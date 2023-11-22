


namespace OBS.Model
{
    /// <summary>
    /// �о����ϴ��ε����������
    /// </summary>
    public class ListPartsRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "ListParts";
        }

        /// <summary>
        /// ��������
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        ///  </para> 
        /// </remarks>
        public string ObjectKey
        {
            get;
            set;
        }

        /// <summary>
        /// �о����ϴ��Ķη��ؽ��������Ŀ��  
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        ///  </para> 
        /// </remarks>
        public int? MaxParts
        {
            get;
            set;
        }

        /// <summary>
        /// ���г��ε���ʼλ�á�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        ///  </para> 
        /// </remarks>
        public int? PartNumberMarker
        {
            get;
            set;
        }


        /// <summary>
        /// �ֶ��ϴ������ID�š�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        ///  </para> 
        /// </remarks>
        public string UploadId
        {
            get;
            set;
        }

    }
}
    
