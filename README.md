# TrilhaCQRS
 Esse projeto tem como objetivo implementar exemplos de frameworks e padrões para consolidação do conhecimento sobre CQRS. </br>
 
 <h6>MongoDB</h6>
 <p>
    O exemplo de MongoDB foi criado pensando na otimização de dados da "base de consulta", nesse exemplo foi criado um Repository generico com as operações básicas de um CRUD.
 </p>
<h6>Dapper</h6>
<p>
  O exemplo do Dapper foi criado para flexibilizar o Repository da arquitetura CQRS em SGBS relacionais, uma vez que ORMs "tradicioanis" pode não ter a mesma performance que um micro-orm.
</p>
<p>
  Para ter uma visão mais clara sobre a diferença performance veja o <a href="http://www.c-sharpcorner.com/UploadFile/4d9083/performing-crud-operation-with-dapper-in-mvc/">benchmark</a>
</p>
<h6>Identity Server 3</h6>
<p>
  Geralmente quando estamos lendo algo sobre CQRS não tem muitas informações sobre como integrar a Autenticação e Autorização em uma arquitetura CQRS, esse é o objeto dessa parte! construir um servidor de autenticação e autorização separado da aplicação porém fornecendo autorização para as APIs de todos os Bounded Context (Isso não é obrigatório mas com certeza irá cair bem em varios cenários de negócio)
<p>
