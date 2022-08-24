# Testes-Unitarios-IHttpActionResult
Projeto de Exemplo com testes unitários para IHttpActionResult

Projeto que vai ser testado deve conter a diretiva expondo os tipos classificados como Internal, pois estamos usando dynamic e o tipos assinados como dynamic são internal.

```c#
[assembly: InternalsVisibleTo("WebAppSampleTestApi.Tests")]
```

Para o projeto de teste devemos adicionar referência para 

```xml
  <package id="Microsoft.CSharp" version="4.7.0" targetFramework="net471" />
```

Controller 

```c#
    public class DefaultController : ApiController
    {
        public IHttpActionResult Get(string id)
        {
            var data = new { Success = true, Data = id };
            return Ok(data);
        }
    }
```

Teste da Controller

```c#
    [TestClass]
    public class DefaultControllerTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new DefaultController();
            dynamic result = controller.Get("10");
            dynamic response = result.Content;

            Assert.AreEqual(true, response.Success);
            Assert.AreEqual("10", response.Data);
        }
    }
```


