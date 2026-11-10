using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_052_JA_04 : CardInfo
{
    public CardInfo_052_JA_04()
    {
        this.cardNo = "052_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ポット夫人";
        this.cardName2 = "魔法のティーポット";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.VeronicaDiLorenzoAndLivioCacciatore;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
