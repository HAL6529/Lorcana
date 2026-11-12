using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_092_JA_07 : CardInfo
{
    public CardInfo_092_JA_07()
    {
        this.cardNo = "092_JA_07";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "シア・カーン";
        this.cardName2 = "悪名高いトラ";
        this.power = 4;
        this.toughness = 4;
        this.lore = 4;
        this.illustrator = EnumController.Illustrator.StefanoZanchi;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheJungleBook;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
