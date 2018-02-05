﻿using System;
using Chloe.Entity;

namespace Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("T_Queue")]
    public class TQueueModel
    {

        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string idCard { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string qNmae { get; set; }

        /// <summary>
        /// 排队号
        /// </summary>
        public string qNumber { get; set; }

        /// <summary>
        /// 票号
        /// </summary>
        public string ticketNumber { get; set; }

        /// <summary>
        /// 排队时间
        /// </summary>
        public DateTime ticketTime { get; set; }

        /// <summary>
        /// 业务类型编码
        /// </summary>
        public string busTypeSeq { get; set; }

        /// <summary>
        /// 业务类型名称
        /// </summary>
        public string busTypeName { get; set; }

        /// <summary>
        /// 窗口号
        /// </summary>
        public string windowNumber { get; set; }

        /// <summary>
        /// 窗口名称
        /// </summary>
        public string windowName { get; set; }

        /// <summary>
        /// 单位名称
        /// </summary>
        public string unitName { get; set; }

        /// <summary>
        /// 单位编码
        /// </summary>
        public string unitSeq { get; set; }

        /// <summary>
        /// vip级别
        /// </summary>
        public string vipLever { get; set; }

        /// <summary>
        /// 处理状态(排队中0、已处理1)
        /// </summary>
        public int state { get; set; }

        /// <summary>
        /// 预约号
        /// </summary>
        public string reserveSeq { get; set; }

        /// <summary>
        /// 预约类型（0：后预约 1：先预约）
        /// </summary>
        public int appType { get; set; }

        /// <summary>
        /// 预约开始时间
        /// </summary>
        public DateTime reserveStartTime { get; set; }

        /// <summary>
        /// 预约结束时间
        /// </summary>
        public DateTime reserveEndTime { get; set; }

    }
}

