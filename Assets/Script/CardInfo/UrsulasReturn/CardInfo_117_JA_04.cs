using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_117_JA_04 : CardInfo
{
    public CardInfo_117_JA_04()
    {
        this.cardNo = "117_JA_04";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ナマーリ";
        this.cardName2 = "ファングを継ぐもの";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KasiaBrzezinska;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
