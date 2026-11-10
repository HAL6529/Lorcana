using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_186_JA_04 : CardInfo
{
    public CardInfo_186_JA_04()
    {
        this.cardNo = "186_JA_04";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "魔法のほうき";
        this.cardName2 = "バケツリレーの指揮者";
        this.power = 2;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.OttoParedes;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Broom };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Fantasia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
