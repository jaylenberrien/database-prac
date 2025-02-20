using System.ComponentModel;
using System.Runtime.ExceptionServices;
using Dapper;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using DotEnv.Core;
using System.Data.Common;
using NuGet.Protocol.Plugins;
using Microsoft.EntityFrameworkCore;



new EnvLoader().AddEnvFile(".env").Load();
var reader = new EnvReader();

    
public class MessageController : ControllerBase
{
    
    [HttpPost]
    [Route("api/[post]")]
     public async Task<ActionResult> CreateMessage(string message)
    {
        Console.WriteLine(message);

        string dbConnection = "CONNECTION".GetEnv();

        try
        {
            await using var connection = new SqlConnection(dbConnection);
            var sql = $@"
            insert into dbo.Messages(Message)
            values(${message})
            ";
            var results = await connection.QueryAsync<Message>(sql);

            return Accepted();
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
            return BadRequest();
        }


        
    }



    //attempt at get controller/method for messages





    //attempt at put controller/method for messages





    //attempt at delete controller/method for messages






};







