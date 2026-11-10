using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_119_JA_04 : CardInfo
{
    public CardInfo_119_JA_04()
    {
        this.cardNo = "119_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ノイ";
        this.cardName2 = "アクロバット赤ちゃん";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DennyMinonne;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
