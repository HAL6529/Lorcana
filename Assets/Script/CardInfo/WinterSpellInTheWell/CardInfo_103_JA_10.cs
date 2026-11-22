using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_103_JA_10 : CardInfo
{
    public CardInfo_103_JA_10()
    {
        this.cardNo = "103_JA_10";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ディアブロ";
        this.cardName2 = "目を光らすワタリガラス";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GiuliaLacopiniAndLivioCacciatore;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
