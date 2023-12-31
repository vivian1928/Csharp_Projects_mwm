﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BMap.NET.HTTPService
{
    /// <summary>
    /// 提供导航相关服务
    /// </summary>
    public class DirectionService:ServiceBase
    {
        private static string _direction_url = "http://api.map.baidu.com/direction/v2/driving";  //导航相关

        /// <summary>
        /// 驾车导航
        /// </summary>
        /// <param name="origin">起点</param>
        /// <param name="destination">终点</param>
        /// <param name="origin_region">起点城市</param>
        /// <param name="destination_region">终点城市</param>
        /// <param name="tactics">方案 3：不走高速 5：躲避拥堵 0：最短路径</param>
        /// <returns></returns>
        public JObject DirectionByDriving(string originlat, string originlng, string destinationlat, string destinationlng, int tactics = 0)
        {
            try
            {
                if (_vm == VerificationMode.IPWhiteList)  //IP 白名单校验
                {
                    string url = _direction_url + "?origin=" + originlat + "," + originlng + "&destination=" + destinationlat + "," + destinationlng + "&tactics=" + tactics + "&output=json&ak=" + _ak;
                    string json = DownloadString(url);
                    return JsonConvert.DeserializeObject(json) as JObject;
                }
                else  //SN校验
                {
                    string url = _direction_url + "?origin=" + originlat + "," + originlng + "&destination=" + destinationlat + "," + destinationlng + "&tactics=" + tactics + "&output=json&ak=" + _ak;
                    IDictionary<string, string> param = new Dictionary<string, string> { { "origin", originlat + "," + originlng}, { "destination", destinationlat + "," + destinationlng }, { "tactics", tactics.ToString() }, {"output","json"}, {"mode","driving"}, { "ak", _ak } };

                    string sn = AKSNCaculater.CaculateAKSN(_ak, _sk, _direction_url.Split(new string[] { ".com" }, StringSplitOptions.None)[1], param);  //计算sn
                    string json = DownloadString(url + "&sn=" + sn);
                    return JsonConvert.DeserializeObject(json) as JObject;
                }
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 步行导航
        /// </summary>
        /// <param name="origin">起点</param>
        /// <param name="destination">终点</param>
        /// <param name="region">所在城市</param>
        /// <returns></returns>
        public JObject DirectionByWalking(string origin, string destination, string region)
        {
            try
            {
                if (_vm == VerificationMode.IPWhiteList)  //IP 白名单校验
                {
                    string url = _direction_url + "?origin=" + origin + "&destination=" + destination + "&region=" + region + "&output=json&mode=walking&ak=" + _ak;
                    string json = DownloadString(url);
                    return JsonConvert.DeserializeObject(json) as JObject;
                }
                else  //SN校验
                {
                    string url = _direction_url + "?origin=" + origin + "&destination=" + destination + "&region=" + region + "&output=json&mode=walking&ak=" + _ak;
                    IDictionary<string, string> param = new Dictionary<string, string> { { "origin", origin }, { "destination", destination }, { "region", region }, {"output","json"}, {"mode","walking"}, { "ak", _ak } };

                    string sn = AKSNCaculater.CaculateAKSN(_ak, _sk, _direction_url.Split(new string[] { ".com" }, StringSplitOptions.None)[1], param);  //计算sn
                    string json = DownloadString(url + "&sn=" + sn);
                    return JsonConvert.DeserializeObject(json) as JObject;
                }
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 公交导航
        /// </summary>
        /// <param name="origin">起点</param>
        /// <param name="destination">终点</param>
        /// <param name="region">所在城市</param>
        /// <returns></returns>
        public JObject DirectionByTransit(string origin, string destination, string region)
        {
            try
            {
                if (_vm == VerificationMode.IPWhiteList)  //IP 白名单校验
                {
                    string url = _direction_url + "?origin=" + origin + "&destination=" + destination + "&region=" + region  + "&output=json&mode=transit&ak=" + _ak;
                    string json = DownloadString(url);
                    return JsonConvert.DeserializeObject(json) as JObject;
                }
                else  //SN校验
                {
                    string url = _direction_url + "?origin=" + origin + "&destination=" + destination + "&region=" + region +  "&output=json&mode=transit&ak=" + _ak;
                    IDictionary<string, string> param = new Dictionary<string, string> { { "origin", origin }, { "destination", destination }, { "region", region }, { "output", "json" }, {"mode","transit"}, { "ak", _ak } };

                    string sn = AKSNCaculater.CaculateAKSN(_ak, _sk, _direction_url.Split(new string[] { ".com" }, StringSplitOptions.None)[1], param);  //计算sn
                    string json = DownloadString(url + "&sn=" + sn);
                    return JsonConvert.DeserializeObject(json) as JObject;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
