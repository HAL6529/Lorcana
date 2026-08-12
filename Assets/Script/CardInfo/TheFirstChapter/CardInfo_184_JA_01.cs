using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_184_JA_01 : CardInfo
{
    public CardInfo_184_JA_01()
    {
        this.cardNo = "184_JA_01";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÉäÉç";
        this.cardName2 = "ã‚âÕÇÃÉqÅ[ÉçÅ[";
        this.power = 4;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = "Jared Nickerl";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
