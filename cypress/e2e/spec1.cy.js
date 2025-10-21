describe('template spec', () => {
  it('passes', () => {
    cy.visit('https://example.cypress.io')
  })
  it('can add new todo items', () => {
    cy.visit('https://example.cypress.io/todo')
    
    const newItem = 'Feed the cat'
    cy.get('[data-test=new-todo]').type(`${newItem}{enter}`)

    
    cy.get('.todo-list li')
      .should('have.length', 3)
      .last()
      .should('have.text', newItem)
  })
  // it('new test',()=>{
  //   cy.visit('https://example.cypress.io')

  // })

})