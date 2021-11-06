import './App.css';
import { Component } from 'react';

export default class GitUser extends Component{

  constructor(props){
    super(props);
    this.state = {
      listaRepository: [],
      nomeRepository: ''
    }
  }
 
  buscarRepository = (elemento) => {
    elemento.preventDefault();

    fetch(`https://api.github.com/users/${this.state.nomeRepository}/repos?per_page=10&sort=author-date-desc`)

    .then(response => response.json())

    .then(lista => this.setState({listaRepository: lista}))

    .catch(error => console.log(error))
  }

  atualizarNome = async (nome) => {
    await this.setState({nomeRepository: nome.target.value})
    console.log(this.state.nomeRepository)
  }
  render() {
    return (
      <div>
        <main>
          <section>
            <h2>Busca de Repositorys </h2>
            <form onSubmit={this.buscarRepository}>
              <input type="text" value={this.state.nomeRepository} onChange={this.atualizarNome} placeholder="Úsuario do Github"/>
              <button type="submit">Buscar</button>
            </form>
          </section>
          <section>
            <table>
              <thead>
                <th>Id</th>
                <th>Nome</th>
                <th>Descrição</th>
                <th>Data De Criação</th>
                <th>Tamanho</th>
              </thead>
              <tbody className = "tabela-tr">
                {this.state.listaRepository.map((repo) => {
                  return (
                    <tr key={repo.id}>
                      <td>{repo.id}</td>
                      <td>{repo.name}</td>
                      <td>{repo.description}</td>
                      <td>{repo.created_at}</td>
                      <td>{repo.size}</td>
                    </tr>
                  )
                })}
              </tbody>
            </table>
          </section>
        </main>
      </div>
    )
  }
}



