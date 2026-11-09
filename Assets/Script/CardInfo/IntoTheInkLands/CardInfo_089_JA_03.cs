using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_089_JA_03 : CardInfo
{
    public CardInfo_089_JA_03()
    {
        this.cardNo = "089_JA_03";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "スティッチ";
        this.cardName2 = "秘密捜査官";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Alien };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
