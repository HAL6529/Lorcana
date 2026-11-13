using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_130_JA_07 : CardInfo
{
    public CardInfo_130_JA_07()
    {
        this.cardNo = "130_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "コグスワース";
        this.cardName2 = "飛び上がる時計";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.TonyBancroftAndLindsayWeyman;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
