namespace Password_generator.States.CheckBox
{
    class Check_boxs
    {
        public Check_boxs(IState state) => _state = state;

        private IState _state;

        public void Ischecked(MainWindow mainWindow) => _state.Ischecked(mainWindow);

        public void Isunchecked(MainWindow mainWindow) => _state.Isunchecked(mainWindow);
    }
}
