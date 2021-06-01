/* 
 * AutoRest
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing WeatherForecastApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class WeatherForecastApiTests
    {
        private WeatherForecastApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WeatherForecastApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WeatherForecastApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' WeatherForecastApi
            //Assert.IsInstanceOfType(typeof(WeatherForecastApi), instance, "instance is a WeatherForecastApi");
        }

        /// <summary>
        /// Test WeatherForecastGet
        /// </summary>
        [Test]
        public void WeatherForecastGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.WeatherForecastGet();
            //Assert.IsInstanceOf<List<WeatherForecast>> (response, "response is List<WeatherForecast>");
        }
    }

}
