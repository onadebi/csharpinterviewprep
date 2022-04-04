## Higher Order Components (HOC)
> A higher-order component (HOC) is an advanced technique in React for reusing component logic. HOCs are not part of the React API, per se. They are a pattern that emerges from React’s compositional nature.

---
- Concretely, a higher-order component is a function that takes a component and returns a new component. E.g below:

 ### const EnhancedComponent = higherOrderComponent(WrappedComponent);

- A HOC is a pure function with zero side-effects.
<br/>

> **NB:** [https://reactjs.org/docs/higher-order-components.html] We previously recommended **mixins** as a way to handle cross-cutting concerns. We’ve since realized that mixins create more trouble than they are worth. Read more about why we’ve moved away from mixins and how you can transition your existing components.

---
- Before React 16.8, only class components were able to use the state. Since React 16.8, both the class and function can use state. Function components can use Hooks that let you use state and other React functions without writing a class.

