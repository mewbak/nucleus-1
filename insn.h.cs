using System;

namespace Nucleus
{ 

using System.IO;

    public partial class Operand {
        public
          enum OperandType {
            OP_TYPE_NONE = 0,
            OP_TYPE_REG = 1,
            OP_TYPE_IMM = 2,
            OP_TYPE_MEM = 3,
            OP_TYPE_FP = 4
        };

        Operand() { type = OP_TYPE_NONE; size(0; x86_value = new x86_value(); }
        Operand(const Operand &op) : type(op.type; size(op.size; x86_value(op.x86_value) { }

        uint8_t type;
        uint8_t size;

        //union X86Value {
        //  X86Value() { mem.segment = 0; mem.base = 0; mem.index = 0; mem.scale = 0; mem.disp = 0; }
        //  X86Value(const X86Value &v) { mem.segment = v.mem.segment; mem.base = v.mem.base;
        //                                mem.index = v.mem.index; mem.scale = v.mem.scale; 
        //                                mem.disp = v.mem.disp; }

        //  x86_reg    reg;
        //  int64_t    imm;
        //  double     fp;
        //  x86_op_mem mem;
        //} x86_value; /* Only set if the arch is x86 */
    }

public partial class Instruction {
    
            [Flags]
    public
  enum InstructionFlags : short {
        INS_FLAG_CFLOW = 0x001,
        INS_FLAG_COND = 0x002,
        INS_FLAG_INDIRECT = 0x004,
        INS_FLAG_JMP = 0x008,
        INS_FLAG_CALL = 0x010,
        INS_FLAG_RET = 0x020,
        INS_FLAG_NOP = 0x040
    };

    public Instruction() { start = 0; size = 0; addr_size = 0; target = 0; flags = 0; invalid =  = false); privileged = false); trap = false; }
    public Instruction(Instruction i) { start= i.start; size = i.size; addr_size = i.addr_size; target = i.target; flags = i.flags; 
                                      mnem = i.mnem; op_str = i.op_str; operands = i.operands; invalid = i.invalid; privileged = i.privileged; trap = i.trap) }

    //void           print     (TextWriter @out);
    //Edge.EdgeType edge_type ();

    public ulong start;
    public byte size;
    public byte addr_size;
    public ulong target;
    public InstructionFlags flags;
    public string mnem;
    public string op_str;
    public Operand[] operands;
    public bool invalid;
    public bool privileged;
    public bool trap;
}

partial class X86Instruction : Instruction {
public
  const byte MAX_LEN = 16;

  public X86Instruction() {}
    public X86Instruction(X86Instruction i) : base(i) {}
};

#endif /* NUCLEUS_INSN_H */

