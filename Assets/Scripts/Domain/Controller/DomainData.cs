using UnityEngine;
using System.Collections;

public class DomainData {

	/**
	 * name space of the webservices
	 */
	public static string URL_DOMAIN = "http://localhost:8000/";

	/*
	 * name of provider of service
	 */
	public static string HEADER_SERVICE = "wsdl?";

	/**
	 * name service for get contetn
	 */
	public static string SERVICE_GETCONTENT = "getContent";

	/*
	 * name of service to login in the app
	 */
	public static string SERVICE_LOGIN = "login";

	/*
	 * name of service to register in app
	 */
	public static string SERVICE_REGISTER = "register";

}
