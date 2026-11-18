using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_189_JA_08 : CardInfo
{
    public CardInfo_189_JA_08()
    {
        this.cardNo = "189_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ジーニー";
        this.cardName2 = "ご満悦ドラゴン";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RosaLaBarberaAndLivioCacciatore;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Dragon };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
