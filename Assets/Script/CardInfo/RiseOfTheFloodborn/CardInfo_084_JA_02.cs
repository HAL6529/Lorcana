using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_084_JA_02 : CardInfo
{
    public CardInfo_084_JA_02()
    {
        this.cardNo = "084_JA_02";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "リトル・ジョン";
        this.cardName2 = "義理堅い友";
        this.power = 6;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CristianRomero;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
