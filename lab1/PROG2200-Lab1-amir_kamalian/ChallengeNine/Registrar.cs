

/*
 * author: amir kamalian
 * date:   21 jan 2O23
 * 
 */


namespace Lab1 {

    class Registrar {

        private List<IGraduate> grads;

        public Registrar(List<IGraduate> grads) {
            this.grads = grads;
        }

        public void graduateAll() {
            foreach (IGraduate grad in grads) {
                grad.graduate();
            }
        }
        
    }
 
}



