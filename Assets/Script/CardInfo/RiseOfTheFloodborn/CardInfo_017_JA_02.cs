using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_017_JA_02 : CardInfo
{
    public CardInfo_017_JA_02()
    {
        this.cardNo = "017_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ナナ";
        this.cardName2 = "ダーリング家の愛犬";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FilipeLaurentino;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
