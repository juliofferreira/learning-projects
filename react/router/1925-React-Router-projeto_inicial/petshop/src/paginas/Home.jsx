import React from 'react'
import ListaCaregorias from '../components/ListaCategorias'
import ListaPost from '../components/ListaPost'

const Home = () => {

  return (
    <main>
      <div className="container">
        <h2 className="titulo-pagina">Pet notícias</h2>
      </div>
      <ListaCaregorias />
      <ListaPost url={'/posts'} />
    </main>
  )
}

export default Home
