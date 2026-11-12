using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_103_JA_07 : CardInfo
{
    public CardInfo_103_JA_07()
    {
        this.cardNo = "103_JA_07";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "トゥイードルディー＆トゥイードルダム";
        this.cardName2 = "風変わりな語り手";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald, EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
