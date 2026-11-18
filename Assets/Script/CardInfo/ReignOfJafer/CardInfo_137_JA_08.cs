using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_137_JA_08 : CardInfo
{
    public CardInfo_137_JA_08()
    {
        this.cardNo = "137_JA_08";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "リロ";
        this.cardName2 = "あばれる大かいじゅう";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JulienVandois;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
