import { Grid } from '@mui/material';
import { TextField } from '@mui/material';

  
export default function login(){
    return (
      <div style={{ height: '100%', width: '100%' }}>
        <Grid  container alignItems="center" direction="column" justifyContent="center" rowSpacing={1} columnSpacing={{ xs: 1, sm: 2, md: 3 }}>
          <Grid item xs={12}>
            <Grid  item xs={12}>
            <TextField id="key" label="key" variant="standard" onChange={(e)=>
                  {

                  }} />
            </Grid>
          </Grid>
        </Grid>
    </div>
    )}