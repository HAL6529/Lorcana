using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_193_JA_12 : CardInfo
{
    public CardInfo_193_JA_12()
    {
        this.cardNo = "193_JA_12";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ギズモダック";
        this.cardName2 = "ダックバーグの安全を守る者";
        this.power = 5;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LeonardoGiammichele;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Super, EnumController.Class.Hero, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
