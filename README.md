# ewave-livraria-plenoll

## Projeto realizado com ASP.NET Core e Entity Framework Core

O sistema "To Do" tem como tela ínicial uma grid com listando os empréstimos realizados e um botão para adicionar novos empréstimos.
Nesta grid, a última coluna contem um botão para efetuar a devolução do livro e mais um botão que aparece quando o empréstimo está atrasdo.
Para identificar que um empréstimo está atrasado as linhas com empréstimos atrasados ficam em vermelho e aparece um botão com a opção de adiciona-lo a lista de atrasados.
A navegação para as telas dos usuários, instituição de ensino e livros é realizada pela barra na parte superior da tela.

### Menus Usuário, Instituição de Ensino e Livro
Ao clicar no menu, abrira uma tela com uma grid listando todos os registros relacionados ao menu.
Na última coluna da grid terá três botões:
1 - Edição (Amarelo): ao clicar nesse botão sera direcionado para a tela de edição o qual será possível editar o mesmo, além de ativa-lo ou não.
2 - Detalhes (Azul): ao clicar nesse botão sera direcionado para a tela detalhes do registro selecionado.
3 - Ativar/Desativar: caso o registro esteja ativo, o botão esatara em vermelho e abrirá um modal para confirmar a desativação dele. Caso o registro esteja inativo, o botão estara verde e, ao clicar, abriará um modal para confirmar a ativação do mesmo.

### Novo Emprestimo e Reserva
Será direcionado para uma tela que possui dois campos de pesquisa, um para pesquisar os usuários e outro para pesquisar os livros.
Ao efetuar a pesquisa, no caso dos usuários por nome ou cpf e no caso dos livros por titulo ou autor, os resultados são listados em uma grid.
Ao encontrar os registros que deseja, basta clicar na linha dos registros em questão. Após isso, clicar no botão emprestar, no caso do empréstimo, ou reservar, no caso da reserva.

## Projeto de Teste Unitário do sistema feito em xUnit

Infelizmente não possuo muito conhecimento em testes unitários, porém realizei a criação de uma classe para realizar um teste d inserção de usuário.
