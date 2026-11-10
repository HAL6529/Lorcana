using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_205_JA_04 : CardInfo
{
    public CardInfo_205_JA_04()
    {
        this.cardNo = "205_JA_04";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "シンデレラ";
        this.cardName2 = "メロディの紡ぎ手";
        this.power = 1;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.noc4urne;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Singer9 };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
