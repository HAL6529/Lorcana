using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_217_JA_04 : CardInfo
{
    public CardInfo_217_JA_04()
    {
        this.cardNo = "217_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "アナ";
        this.cardName2 = "誠心なる姫君";
        this.power = 2;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.noc4urne;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Queen, EnumController.Class.Knight };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
